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
        private bool SetLeftList(string lineText)
        {
            var leftTemp = BuildList(lineText);

            if (leftTemp.Count != 10)
            {
                MessageBox.Show("输入的数字有问题，确认一组是否是10个数字，数字之间使用空格分隔");
                return false;
            }
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
        /// 将字符串转换成数组
        /// </summary>
        /// <param name="lineText"></param>
        /// <returns></returns>
        private List<int> BuildList(string lineText)
        {
            var textSplit = lineText.Split(' ');
            var temp = new List<int>();

            foreach (var str in textSplit)
            {
                int i = 0;
                if (int.TryParse(str, out i))
                {
                    temp.Add(i);
                }
            }

            return temp;
        }

        /// <summary>
        /// 获取选择行的数组
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        private void SelectLeftList(int rowIndex)
        {
            if (rowIndex < 0)
                return;
            if (selectedList == null)
                selectedList = new List<List<int>>();

            var selectedItem = BuildList(lbxLeft.Items[rowIndex].ToString());
            if(!selectedList.Contains(selectedItem))
            {
                selectedList.Add(selectedItem);
                lblSelected.Items.Add(lbxLeft.Items[rowIndex]);
                lbxLeft.Items.RemoveAt(rowIndex);
            }
        }

        /// <summary>
        /// 计算左侧的组合与选择的组合
        /// </summary>
        private void ListContains()
        {
            var leftListCopy = new List<List<int>>();
            foreach (var leftItem in lbxLeft.Items)
            {
                leftListCopy.Add(BuildList(leftItem.ToString()));
            }

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
            lbxLeft.Items.Clear();
            foreach(var left in result)
            {
                lbxLeft.Items.Add(string.Join(" ", left.Select(s => s.ToString().PadLeft(2, '0'))));
            }

            List<int> temp = new List<int>();
            foreach (var item in result)
            {
                if (item.Count > 0)
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
            if (selectedList == null || selectedList.Count == 0)
            {
                MessageBox.Show("先选择左侧的数据后再输出");
                return;
            }
            lbxOutput.Items.Clear();
            ListContains();
            SendByteToCOM();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNums.Text))
            {
                MessageBox.Show("先输入数字");
            }

            if (SetLeftList(txtNums.Text))
                lbxLeft.Items.Add(txtNums.Text);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "文本文件|*.txt";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    var allLines = File.ReadAllText(file.FileName);
                    var lines = allLines.Replace("\r", "").Split('\n');
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            if (SetLeftList(line))
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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var leftSelected = lbxLeft.SelectedItems;
            if(leftSelected.Count == 0)
            {
                MessageBox.Show("选择要删除的行，选择多行可按住Ctrl后选择");
                return;
            }
            lbxLeft.SelectedIndexChanged -= lbxLeft_SelectedIndexChanged;
            for (int i = 0;i< leftSelected.Count;)
            {
                var strSelected = leftSelected[i].ToString();
                var selected = BuildList(strSelected);
                var a = selectedList.Find(f => f.ToString() == selected.ToString());
                if (a != null)
                {
                    selectedList.Remove(a);
                    lblSelected.Items.Remove(strSelected);
                }
                lbxLeft.Items.Remove(strSelected);
            }
            lbxLeft.SelectedIndexChanged += lbxLeft_SelectedIndexChanged;
        }

        private void SendByteToCOM()
        {
            COMHelper com = new COMHelper("COM2");
            var result = com.OpenCom();
            if(!result.Success)
            {
                MessageBox.Show(result.Msg);
                return;
            }

            foreach (var row in lbxOutput.Items)
            {
                var output = $"FA DD {row.ToString()} 0D 0A";
                var outputByte = strToHexByte(output);
                result = com.SendData(outputByte);
                if (!result.Success)
                {
                    MessageBox.Show("发送失败：" + result.Msg);
                    break;
                }
            }
        }

        /// <summary>
        /// 字符串转换16进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }
    }
}
