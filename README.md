# Kogane Get Component In Children Type String Extension Methods

GetComponentInChildren や GetComponentsInChildren で引数の型情報を文字列で渡せるようにする拡張メソッド

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        var transform  = gameObject.GetComponentInChildren( "Transform" );
        var transforms = gameObject.GetComponentsInChildren( "Transform" );
    }
}
```