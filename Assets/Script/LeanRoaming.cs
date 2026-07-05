using UnityEngine;

public class RotateSatuJari : MonoBehaviour
{
    // Kecepatan putar 
    public float kecepatanPutar = 0.2f;

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 geseranJari = Input.GetTouch(0).deltaPosition;

            // Menggunakan geseran sumbu X (kiri/kanan) agar burung berputar saat digeser ke samping.
            transform.Rotate(0, 0, -geseranJari.x * kecepatanPutar, Space.Self);
        }
    }
}