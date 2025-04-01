using UnityEngine;

public class OrbitingMotion : MonoBehaviour
{
    public Transform centralSphere;  // ссылка на центральную сферу
    public float orbitSpeed = 10f;   // скорость вращения
    public float orbitRadius = 5f;   // радиус орбиты

    private Vector3 orbitOffset;      // смещение относительно центральной сферы

    void Start()
    {
        // Инициализируем смещение
        orbitOffset = new Vector3(orbitRadius, 0, 0); 
    }

    void Update()
    {
        // Рассчитываем угол вращения
        float angle = orbitSpeed * Time.deltaTime;

        // Обновляем позицию орбитальной сферы
        orbitOffset = Quaternion.Euler(0, angle, 0) * orbitOffset;

        // Устанавливаем новую позицию орбитальной сферы
        transform.position = centralSphere.position + orbitOffset;
    }
}