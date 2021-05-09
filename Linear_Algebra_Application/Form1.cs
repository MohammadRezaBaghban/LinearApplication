using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.String;

namespace Linear_Algebra_Application
{
    public partial class Form1 : Form
    {
        List<Vector> memberRating;
        public Form1()
        {
            InitializeComponent();
            memberRating = new List<Vector>()
            {
                new Vector(new[] { 2, 1, 2, -2, -1, 0, 1, 0, -1, 1 }),
                new Vector(new[] { 2, -2, 1, 2, 1, -1, 0, 2, -1, 1 }),
                new Vector(new[] { 1, 1, -2, 0, -2, -2, 2, 2, 1, 2 }),
                new Vector(new[] { 1, 0, -2, 1, 2, 2, 1, 0, -1, -2 }),
                new Vector(new[] { 1, -1, 1, 1, 2, 0, 2, 1, 0, 1 }),
                new Vector(new[] { 2, 1, -2, 1, 0, 0, 0, 0, 0, 0 })
            };

            memberRating.ForEach(x=> vectorList.Items.Add(x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> array = new List<int>();
            var input = textBox1.Text.Replace(" ", "").Split(',').ToList();
            input.ForEach(x => array.Add(Convert.ToInt32(x)));
            var vector = new Vector(array.ToArray());
            vectorList.Items.Add(vector);
        }

        private void vectorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vectorList.SelectedItem != null)
            {
                var selectedItem = vectorList.SelectedItem as Vector;
                lb_array1.Text = $"Array 1: {selectedItem.ToString()}";
                lb_array1.Tag = selectedItem;
            }
        }

        private void btn_Vector2_Click(object sender, EventArgs e)
        {
            if (vectorList.SelectedItem != null)
            {
                var selectedItem = vectorList.SelectedItem as Vector;
                lb_array2.Text = $"Array 2: {selectedItem.ToString()}";
                lb_array2.Tag = selectedItem;
            }
        }
    }

    public class Vector
    {
        private int[] value;

        public Vector(int[] array) => this.value = array;

        public override string ToString()
        {
            return "[" + Join(",", value) + "]";
        }
    }
}
