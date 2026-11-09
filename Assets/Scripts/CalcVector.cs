using NUnit.Framework.Interfaces;
using UnityEngine;

public class CalcVector : MonoBehaviour
{
    public Vector3 A = new Vector3(-2, 3, -4);
    public Vector3 B = new Vector3(5, 3, 6);
    public Vector3 Result = Vector3.zero;
    public float DotResult = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        Result = Additive(A, B);
        Result = Subtract(A, B);
        DotResult = DotMultiply(A, B);
        Result = CrossMultiply(A, B);
    }


    /// <summary>
    /// ベクトル同士の足し算
    /// </summary>
    public Vector3 Additive(Vector3 a, Vector3 b)
    {
        var result = a + b;

        // ベクトルの可視化
        //始点、方向ベクトル、色、描画時間、深度、
        Debug.DrawRay(Vector3.zero, a, Color.red, 0.0f, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0.0f, false);
        Debug.DrawRay(Vector3.zero, result, Color.green, 0.0f, false);

        return result;
    }

    public Vector3 Subtract(Vector3 a, Vector3 b)
    {
        var result = a - b;

        Debug.DrawRay(Vector3.zero, a, Color.red, 0.0f, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0.0f, false);
        Debug.DrawRay(Vector3.zero, result, Color.green, 0.0f, false);

        return result;
    }

    public float DotMultiply(Vector3 a, Vector3 b)
    {
        var result = (a.x * b.x) + (a.y * b.y) + (a.z + b.z);

        Debug.Log($"{a}と{b}の内積＝{result}");

        return result;
    }

    public Vector3 CrossMultiply(Vector3 a, Vector3 b)
    {
        var result = Vector3.zero;

        //result.x = a.y * b.z - a.z * b.y;
        //result.y = a.z * b.x - a.x * b.z;
        //result.z = a.x * b.y - a.y * b.x;

        result = Vector3.Cross(a, b);

        Debug.DrawRay(Vector3.zero, result, Color.green, 0.0f, false);

        return result;
    }
}
