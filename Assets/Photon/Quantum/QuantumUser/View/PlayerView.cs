namespace Quantum {
  using Photon.Deterministic;
  using Spine.Unity;
  using UnityEngine;

  public enum AnimationName {
    Idle, Walk, Attack
  }

  public unsafe class PlayerView : QuantumEntityViewComponent {
    public const string ANIM_IDLE = "Idle";
    public const string ANIM_WALK = "Walk";
    public const string ANIM_ATTACK = "Attack";

    public Quaternion rotationLeft;
    public Quaternion rotationRight;

    private Animator animator;
    private PhysicsBody2D body;
    private PlayerInfo playerInfo;
    private AnimationName currentAnim;

    public bool spawnBullet = false;

    private void Awake() {
      animator = GetComponentInChildren<Animator>();
      QuantumCallback.Subscribe(this, (CallbackPollInput callback) => PollInput(callback));
    }

    private void Update() {
      // Get physics & input
      body = VerifiedFrame.Get<PhysicsBody2D>(_entityView.EntityRef);
      playerInfo = VerifiedFrame.Get<PlayerInfo>(_entityView.EntityRef);
      var input = VerifiedFrame.GetPlayerInput(playerInfo.PlayerRef);

      // Kiểm tra animation hiện tại
      currentAnim = GetCurrentAnimation();

      // Nếu đang không Attack thì play Walk nếu có di chuyển
      if (currentAnim != AnimationName.Attack && body.Velocity != FPVector2.Zero) {
        animator.Play(ANIM_WALK);
      } else if (currentAnim != AnimationName.Attack && body.Velocity == FPVector2.Zero) {
        animator.Play(ANIM_IDLE);
      }

      // Nếu nhấn Attack
      if (input->Attack.WasPressed) {
        animator.Play(ANIM_ATTACK, 0, 0f);
        spawnBullet = true;
      }

      // Xoay mặt theo hướng
      if (body.Velocity.X > 0) {
        animator.transform.rotation = rotationRight;
      } else if (body.Velocity.X < 0) {
        animator.transform.rotation = rotationLeft;
      }
    }

    private AnimationName GetCurrentAnimation() {
      if (animator == null) return AnimationName.Idle;

      var stateInfo = animator.GetCurrentAnimatorStateInfo(0);

      if (stateInfo.IsName(ANIM_ATTACK)) {
        // Khi animation Attack chạy xong thì trả về Idle
        if (stateInfo.normalizedTime >= 1f)
          return AnimationName.Idle;
        return AnimationName.Attack;
      }

      if (stateInfo.IsName(ANIM_WALK))
        return AnimationName.Walk;

      return AnimationName.Idle;
    }

    public void PollInput(CallbackPollInput callback) {
      if (!QuantumRunner.DefaultGame.PlayerIsLocal(playerInfo.PlayerRef))
        return;

      Quantum.Input input = new Quantum.Input();
      FP x, y;
      GetPlayerInputDirection(out x, out y);

      input.Direction = new FPVector2(x, y);
      input.Attack = UnityEngine.Input.GetKey(KeyCode.Space);
      input.SpawnBullet = spawnBullet;

      if (spawnBullet)
        spawnBullet = false;

      callback.SetInput(input, DeterministicInputFlags.Repeatable);
    }

    private void GetPlayerInputDirection(out FP x, out FP y) {
      x = 0;
      y = 0;

      // Nếu đang tấn công thì không di chuyển
      if (currentAnim == AnimationName.Attack)
        return;

      if (UnityEngine.Input.GetKey(KeyCode.RightArrow)) x = 1;
      else if (UnityEngine.Input.GetKey(KeyCode.LeftArrow)) x = -1;

      if (UnityEngine.Input.GetKey(KeyCode.UpArrow)) y = 1;
      else if (UnityEngine.Input.GetKey(KeyCode.DownArrow)) y = -1;
    }
  }
}