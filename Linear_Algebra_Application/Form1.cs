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
        private Vector vector1 = null;
        private Vector vector2 = null;

        public Form1()
        {
            InitializeComponent();
            memberRating = new List<Vector>()
            {
                new Vector(new[] { 2, 1, 2, -2, -1, 0, 1, 0, -1, 1 }),
                new Vector(new[] { 2, -2, 1, 2, 1, -1, 0, 2, -1, 1 }),
                new Vector(new[] { 1, 1, -2, 0, -2, -2, 2, 2, 1, 2 }),
                new Vector(new[] { 1, 0, -2, 1, 2, 2, 1, 0, -1, -2 }, "Closest"),
                new Vector(new[] { 1, -1, 1, 1, 2, 0, 2, 1, 0, 1 }),
                new Vector(new[] { 2, 1, -2, 1, 0, 3, 3, 3, 3, 3 }, "Guess"),
                new Vector(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "I Vector"),
                new Vector(new[] {  2, 1, -2, 1, 0, 0, -1, 2, 1,1}, "Actual"),


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
                vector1 = selectedItem;
            }
        }

        private void btn_Vector2_Click(object sender, EventArgs e)
        {
            if (vectorList.SelectedItem != null)
            {
                var selectedItem = vectorList.SelectedItem as Vector;
                lb_array2.Text = $"Array 2: {selectedItem.ToString()}";
                vector2 = selectedItem;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (vectorList.SelectedItem != null)
            {
                var selectedItem = vectorList.SelectedItem as Vector;
                var lengthPower2 = Matrix.Vector_Length(selectedItem.value);
                lb_VectorLength.Text = $"squre root of {lengthPower2} = {Math.Round(Math.Sqrt(lengthPower2),2)}";
            }
        }

        private void btn_DotProdoct_Click(object sender, EventArgs e)
        {
            if (vector2 == null || vector1 == null) 
                MessageBox.Show("Select Two vector of same size");
            else
            {
                var dotProduct = Matrix.Dot_Product(vector1.value, vector2.value);
                lb_DotProduct.Text = $"Dot Product = {dotProduct}";
            }
        }

        private void Btn_Angle_Click(object sender, EventArgs e)
        {
            if (vector2 == null || vector1 == null)
                MessageBox.Show("Select Two vector of same size");
            else
            {
                var cosine = Math.Round(Matrix.Angle_Two_Vector(vector1.value, vector2.value),3);
                lb_Angle.Text = $"Cosine = {cosine}\n" +
                                $"Angle in Degree = {Matrix.Cosine_Reverse(cosine)}";
            }
        }
    }

    public class Vector
    {
        public int[] value;
        public string name;

        public Vector(int[] array, string name = "No-Name")
        {
            value = array;
            this.name = name;
        }

        public override string ToString() => name +": [" + Join(",", value) + "]";
    }
}
