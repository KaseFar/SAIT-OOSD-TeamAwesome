﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    class Validator
    {
        //check if the string is an int
        public static bool inputIsInteger(string input, out string msg)
        {
            int value;
            msg = "";
            if (int.TryParse(input, out value))
            { //input is an integer
                return true;
            }
            //input is not an integer
            msg = "Please use whole numbers";
            return false;
        }
        //check if  min <= input <= max
        public static bool inputRangeIsValid(int input, int min, int max, out string msg)
        {
            if (input >= min && input <= max) //input is in range
            {
                msg = "";
                return true;
            }
            //input is out of range
            msg = "Please use numbers between "+min +" and "+ max;
            return false;
        }
        //checks if string is not empty
        public static bool notEmpty(string input, out string msg)
        {

            if (input.Length != 0 && input.Trim().Length != 0)//input is not empty
            {
                msg = "";
                return true;
            }
            //input is empty
            msg = "Please dont leave this field blank";
            return false;
        }

        // Checks to see if the textbox has a value
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Please select a " + textBox.Tag + ".", "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
