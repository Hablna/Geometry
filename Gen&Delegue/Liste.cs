using System.Collections;
using Gen_Delegue;


//je veux pouvoir faire des for et des foreach
//IEnumerable<T> est une interface qui permet de faire des foreach

internal class Liste<T> : IEnumerable<T>
{
    private readonly ArrayList list;

    public int Count => list.Count;

    public T this[int index] => (T)list[index];
    public Liste()
    {
        list = new ArrayList();
    }
    public void Ajouter(T element)
    {
        list.Add(element);
    }

    public IEnumerator<T> GetEnumerator()
        => list.GetEnumerator() as IEnumerator<T>;
    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();

    //tri par inversion
    public void trier(delegueQuiCompare<T> test)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (test((T)list[i], (T)list[j]))
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
    }
}