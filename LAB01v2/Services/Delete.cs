using LAB01v2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01v2.Services
{
	internal class Delete
	{
		BindingList<TableModel> output = new BindingList<TableModel>();
		TableModel[] arrayToReduce, arrayReduced;

		private void toArray(BindingList<TableModel> input)
		{
			arrayToReduce = new TableModel[input.Count];
			int i = 0;
			foreach (var item in input)
			{
				arrayToReduce[i++] = item;
			}
		}
		private void fromArray()
		{
			output.Clear();
			foreach (var item in arrayReduced)
			{
				output.Add(item);
			}
		}
		public BindingList<TableModel> ByDetail (BindingList<TableModel> input, string detail)
		{
			toArray(input);
			int n = 0;
			for (int i = 0; i < arrayToReduce.Length; i++)
			{
				if (arrayToReduce[i].Detail.ToString() != detail) n++;
			}
			arrayReduced = new TableModel[n];
			n = 0;
			for (int i = 0; i < arrayToReduce.Length; i++)
			{
				if (arrayToReduce[i].Detail != detail)
				{
					arrayReduced[n++] = arrayToReduce[i];
				}					
			}
			fromArray();
			return output;
		}
	}
}
