using LAB01v2.Models;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace NickMikhailov
{
    internal class Sort
    {
        BindingList<TableModel> output = new BindingList<TableModel>();
        TableModel[] arrayToSort;

        private void toArray (BindingList<TableModel> input)
        {
            arrayToSort = new TableModel[input.Count];
            int i=0;
            foreach (var item in input)
            {
                arrayToSort[i++] = item;
            }
        }
        private void fromArray()
        {
            output.Clear();
            foreach (var item in arrayToSort)
            {
                output.Add(item);
            }
        }
        private void swap(ref TableModel a, ref TableModel b)
        {
            TableModel temp = a;
            a = b;
            b = temp;
        }
        public BindingList<TableModel> ByID(BindingList<TableModel> input, bool descending = false)
        {
            toArray(input);
            for (int i=0; i<input.Count; i++)
            {
                for (int j = 0; j<input.Count -1; j++)
                {

                    if (descending ? arrayToSort[j].Id < arrayToSort[j+1].Id: arrayToSort[j].Id > arrayToSort[j + 1].Id)
                    {
                        swap(ref arrayToSort[j], ref arrayToSort[j+1]);
                    }
                }
            }
            fromArray();
            return output;
        }
        public BindingList<TableModel> ByDetail(BindingList<TableModel> input, bool descending = false)
        {
            toArray(input);
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count - 1; j++)
                {
                    //побуквенная проверка равенства слов
                    int k=0, kmax = Math.Min(arrayToSort[j].Detail.Length, arrayToSort[j + 1].Detail.Length);
                    while (k < kmax && arrayToSort[j].Detail[k] == arrayToSort[j + 1].Detail[k]) k++;
                    if (k == kmax) continue;
                    //далее сортировка по первому различному символу

                    if (descending ? arrayToSort[j].Detail[k] < arrayToSort[j + 1].Detail[k] : arrayToSort[j].Detail[k] > arrayToSort[j + 1].Detail[k])
                    {
                        swap(ref arrayToSort[j], ref arrayToSort[j + 1]);
                    }
                }
            }
            fromArray();
            return output;
        }
        public BindingList<TableModel> ByCell(BindingList<TableModel> input, bool descending = false)
        {
            toArray(input);
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count - 1; j++)
                {
                    if (descending ? arrayToSort[j].Cell < arrayToSort[j + 1].Cell : arrayToSort[j].Cell > arrayToSort[j + 1].Cell)
                    {
                        swap(ref arrayToSort[j], ref arrayToSort[j + 1]);
                    }
                }
            }
            fromArray();
            return output;
        }
        public BindingList<TableModel> ByQuantity(BindingList<TableModel> input, bool descending = false)
        {
            toArray(input);
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count - 1; j++)
                {
                    if (descending ? arrayToSort[j].Quantity < arrayToSort[j + 1].Quantity : arrayToSort[j].Quantity > arrayToSort[j + 1].Quantity)
                    {
                        swap(ref arrayToSort[j], ref arrayToSort[j + 1]);
                    }
                }
            }
            fromArray();
            return output;
        }
    }    
}
