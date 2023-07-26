using UnityEngine;
using System.Collections;

public class ExampleSceneScript : MonoBehaviour
{

    // nothing to do, we just need the "ExampleSceneScript" in order to call the "TagHelper" that add tags for examples coin.
    // 何もする必要はありません。ただ、「ExampleSceneScript」を使用して、「TagHelper」を呼び出すだけです。これにより、例のコインに必要なタグが追加されます。

    public void DestroyMe()
    {
        DestroyImmediate(this.gameObject);
    }
}
