using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAndC
{
    public partial class Form1 : Form
    {
        List<List<int>> leftList = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //左侧数据
            leftList = BuildLeftList();
            var leftListCopy = leftList;

            //选择后的数据
            List<int[]> selectedList = new List<int[]>();
            selectedList.Add(SelectLeftList(0));
            //selectedList.Add(SelectLeftList(3));

            //选择后的数据的组合
            List<int[]> selectedCombinationList = new List<int[]>();
            foreach(var item in selectedList)
            {
                selectedCombinationList.AddRange(PermutationAndCombination<int>.GetCombination(item, 5));
            }

            //判断左侧重复的组合
            foreach (var item in leftList)
            {
                var leftCombinations = PermutationAndCombination<int>.GetCombination(item, 5);

                foreach (var lItem in leftCombinations)
                {
                    foreach(var sItem in selectedCombinationList)
                    {
                        if (sItem.All(lItem.Contains))
                        {
                            ArrayList arrayList = new ArrayList(item);
                            arrayList.Remove()
                        }
                    }
                }
            }
        }
        
        private List<List<int>> BuildLeftList()
        {
            List<List<int>> list = new List<List<int>>();
            list.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            list.Add(new List<int> { 2, 3, 4, 5, 6, 7, 8, 10, 11, 13 });
            list.Add(new List<int> { 2, 5, 6, 7, 8, 9, 10, 13, 15, 17 });
            list.Add(new List<int> { 1, 2, 5, 6, 7, 8, 9, 13, 14, 15 });
            list.Add(new List<int> { 3, 4, 5, 6, 7, 9, 10, 11, 12, 13 });
            return list;
        }

        private int[] SelectLeftList(int rowIndex)
        {
            if(rowIndex < 0 || rowIndex > leftList.Count)
                return new int[]{};
            return leftList[rowIndex];
        }
    }
}
