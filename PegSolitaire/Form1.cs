using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Xunit;

namespace PegSolitaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public void changeLabelText(string newText)
        {
            label1.Text = newText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortTests s = new SortTests();
            s.SortAnArray();
            s.Add_TwoNumbers_ReturnsSum();
            //label1.Text = s.SortAnArray();
        }

        public static T[] merge<T>(T[] arr1, T[] arr2) where T : IComparable
        {
            if (arr1.Length == 0 && arr2.Length == 1) return arr2;
            else if (arr2.Length == 0 && arr1.Length == 1) return arr1;

            if (arr1.Length == 0 && arr2.Length == 0) return arr1;

            int idx1 = 0;
            int idx2 = 0;

            T[] newArr = new T[arr1.Length + arr2.Length];
            int newArrIdx = 0;

            while (idx1 < arr1.Length && idx2 < arr2.Length)
            {
                int compareResult = arr1[idx1].CompareTo(arr2[idx2]);

                if (compareResult == -1)
                { //if evaluated arr1 value is less than evaluated arr2 val, then add it to the "merged" array, so it's an ascending list of values
                    newArr[newArrIdx++] = arr1[idx1++];
                }
                else
                {
                    newArr[newArrIdx++] = arr2[idx2++];
                }
            }

            if (idx1 == arr1.Length)
            { //one array ran out of things to add, add the rest of other arr to newArr
                Array.Copy(arr2, idx2, newArr, newArrIdx, arr2.Length - idx2);
            }
            else
            {
                Array.Copy(arr1, idx1, newArr, newArrIdx, arr1.Length - idx1);
            }

            return newArr;
        }

        public static T[] MergeSort<T>(T[] arr) where T : IComparable
        {

            T[] left = new T[arr.Length / 2];
            T[] right = new T[arr.Length - arr.Length / 2];

            Array.Copy(arr, 0, left, 0, arr.Length / 2);
            Array.Copy(arr, arr.Length / 2, right, 0, arr.Length - arr.Length / 2);

            if (left.Length == 1 || right.Length == 1)
            {
                return merge(left, right);
            }
            else
            {
                return merge(MergeSort(left), MergeSort(right));
            }

        }

    }

    public class SortTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = Form1.Add(2, 3);

            Assert.Equal(5, result);
            Debug.WriteLine("Test for addition passed!");
        }

        [Fact]
        public void SortAnArray()
        {
            int[] result = Form1.MergeSort(new int[] { 5, 1, 3, 77, 3, 6});

            Assert.Equal(new int[] { 1, 3, 3, 5, 6, 77}, result);
            Debug.WriteLine("Test for array sorting passed!");
        }
    }
}