namespace Quantum {
  using UnityEngine;

  public class BulletView : QuantumEntityViewComponent {
    public Quaternion rotationLeft;  // Quay khi viên đạn đi sang trái
    public Quaternion rotationRight; // Quay khi viên đạn đi sang phải
    public Transform visual;         // Transform của viên đạn để thay đổi hướng quay
    public float speed = 10f;        // Tốc độ di chuyển của viên đạn

    private BulletInfo bulletInfo;
    private Rigidbody rb;

    private void Start() {
      rb = GetComponent<Rigidbody>();  // Lấy Rigidbody của viên đạn
    }

    private void Update() {
      // Lấy thông tin viên đạn
      if (VerifiedFrame.TryGet<BulletInfo>(_entityView.EntityRef, out bulletInfo)) {
        // Kiểm tra xem viên đạn đang hướng sang trái hay phải
        if (bulletInfo.Facing == PlayerFacing.Left) {
          visual.rotation = rotationLeft;      // Gán góc quay khi viên đạn hướng sang trái
          rb.linearVelocity = -transform.forward * speed;  // Di chuyển sang trái
        } else {
          visual.rotation = rotationRight;     // Gán góc quay khi viên đạn hướng sang phải
          rb.linearVelocity = transform.forward * speed;   // Di chuyển sang phải
        }
      }
    }
  }
}