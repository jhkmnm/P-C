using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAndC
{
    public partial class Form1 : Form
    {
        List<List<int>> leftList = null;
        List<List<int>> selectedList = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        /// 将文本转成数组，数字之间使用空格分隔
        /// </summary>
        /// <param name="lineText">单行文本</param>
        private bool BuildLeftList(string lineText)
        {
            var textSplit = lineText.Split(' ');
            var leftTemp = new List<int>();

            foreach(var str in textSplit)
            {
                int i = 0;
                if(int.TryParse(str, out i))
                {
                    leftTemp.Add(i);
                }
            }

            if(leftTemp.Count != 10)
            {
                MessageBox.Show("输入的数字有问题，确认一组是否是10个数字，数字之间使用空格分隔");
                return false;
            }

            if(leftList == null)
            {
                leftList = new List<List<int>>();
            }

            leftList.Add(leftTemp);
            return true;
            //List<List<int>> list = new List<List<int>>();
            //list.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //list.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //list.Add(new List<int> { 2, 3, 4, 5, 6, 7, 8, 10, 11, 13 });
            //list.Add(new List<int> { 2, 5, 6, 7, 8, 9, 10, 13, 15, 17 });
            //list.Add(new List<int> { 1, 2, 5, 6, 7, 8, 9, 13, 14, 15 });
            //list.Add(new List<int> { 3, 4, 5, 6, 7, 9, 10, 11, 12, 13 });
        }

        /// <summary>
        /// 获取选择行的数组
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        private void SelectLeftList(int rowIndex)
        {
            if(rowIndex < 0 || rowIndex > leftList.Count)
                return;
            if (selectedList == null)
                selectedList = new List<List<int>>();

            var selectedItem = leftList[rowIndex];
            if(!selectedList.Contains(selectedItem))
            {
                selectedList.Add(selectedItem);
                lblSelected.Items.Add(lbxLeft.Items[rowIndex]);
            }            
        }

        /// <summary>
        /// 计算左侧的组合与选择的组合
        /// </summary>
        private void ListContains()
        {
            var leftListCopy = ObjectCopier.Clone(leftList);
            //leftList.ForEach(i => leftListCopy.Add(i));

            //选择后的数据的组合
            List<int[]> selectedCombinationList = new List<int[]>();
            foreach (var item in selectedList)
            {
                selectedCombinationList.AddRange(PermutationAndCombination<int>.GetCombination(item.ToArray(), 5));
            }

            //判断左侧重复的组合
            foreach (var leftItem in leftListCopy)
            {
                var leftCombinations = PermutationAndCombination<int>.GetCombination(leftItem.ToArray(), 5);

                foreach (var lcItem in leftCombinations) //左侧的组合
                {
                    if (selectedCombinationList.Any(s => s.All(lcItem.Contains)))
                    {
                        foreach (var i in lcItem)   //选择的组合
                        {
                            leftItem.Remove(i);
                        }
                    }
                }
            }

            OuputResult(leftListCopy);
        }

        private void OuputResult(List<List<int>> result)
        {
            List<int> temp = new List<int>();
            foreach(var item in result)
            {
                if(item.Count > 0)
                {
                    temp.AddRange(item);
                }
            }

            var strPers = temp.Distinct().OrderBy(o => o).Select(s => s.ToString().PadLeft(2, '0'));
            var index = 0;
            var pa = strPers.Skip(index++ * 5).Take(5);
            while (pa.Count() > 0)
            {
                lbxOutput.Items.Add(string.Join(" ", pa));
                pa = strPers.Skip(index++ * 5).Take(5);
            }
        }

        private void btnClearA_Click(object sender, EventArgs e)
        {
            selectedList.Clear();
            lblSelected.Items.Clear();
        }

        private void btnClearB_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(selectedList == null || selectedList.Count == 0)
            {
                MessageBox.Show("先选择左侧的数据后再输出");
                return;
            }
            ListContains();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNums.Text))
            {
                MessageBox.Show("先输入数字");
            }

            if(BuildLeftList(txtNums.Text))
            {
                lbxLeft.Items.Add(txtNums.Text);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "文本文件|*.txt";
                if(file.ShowDialog() == DialogResult.OK)
                {
                    var allLines = File.ReadAllText(file.FileName);
                    var lines = allLines.Replace("\r", "").Split('\n');
                    foreach(var line in lines)
                    {
                        if(!string.IsNullOrEmpty(line))
                        {
                            if (BuildLeftList(line))
                                lbxLeft.Items.Add(line);
                            else
                                break;
                        }                        
                    }
                }
            }
        }

        private void lbxLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectLeftList(lbxLeft.SelectedIndex);
        }
    }
}
