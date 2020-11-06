using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RobotController
{
    public struct MyQuat
    {

        public float w;
        public float x;
        public float y;
        public float z;
    }

    public struct MyVec
    {

        public float x;
        public float y;
        public float z;
    }






    public class MyRobotController
    {
        private int slowCounter = 0;
        private int counter = 0;
        #region public methods



        public string Hi()
        {

            string s = "hello GiTrasHub from my Robot Controller";
            return s;

        }


        //EX1: this function will place the robot in the initial position

        public void PutRobotStraight(out MyQuat rot0, out MyQuat rot1, out MyQuat rot2, out MyQuat rot3) {
            float angle;
            MyVec axis;
            
            axis.x = 1;
            axis.y = 0;
            axis.z = 0;
            angle = (float)Math.PI * (-12) / 180;
            rot1 = Rotate(NullQ, axis, angle);
            angle = (float)Math.PI * 110 / 180;
            rot2 = Rotate(NullQ, axis, angle);
            angle = (float)Math.PI * 90 / 180;
            rot3 = Rotate(NullQ, axis, angle);

            angle = (float)Math.PI * 73 / 180;
            axis.x = 0;
            axis.y = 1;
            axis.z = 0;
            //todo: change this, use the function Rotate declared below
            rot0 = Rotate(NullQ, axis, angle);
            rot1 = Rotate(rot1, axis, angle);
            rot2 = Rotate(rot2, axis, angle);
            rot3 = Rotate(rot3, axis, angle);
            

        }



        //EX2: this function will interpolate the rotations necessary to move the arm of the robot until its end effector collides with the target (called Stud_target)
        //it will return true until it has reached its destination. The main project is set up in such a way that when the function returns false, the object will be droped and fall following gravity.


        public bool PickStudAnim(out MyQuat rot0, out MyQuat rot1, out MyQuat rot2, out MyQuat rot3)
        {
            float angle;
            MyVec axis;
            slowCounter++;
            if (slowCounter > 2)
            {
                slowCounter = 0;
                counter++;
            }
            if (counter < 20)
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * (-12 - counter) / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (110 + counter) / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (90 - counter) / 180;
                rot3 = Rotate(NullQ, axis, angle);

                angle = (float)Math.PI * 73 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return true;
            }
            else if (counter < 50)
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * (-32) / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (130) / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (70) / 180;
                rot3 = Rotate(NullQ, axis, angle);

                angle = (float)Math.PI * (93-counter) / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return true;
            }
            else if (counter < 70)
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * (-32 + counter - 50) / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (130 - counter + 50) / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (70 + counter - 50) / 180;
                rot3 = Rotate(NullQ, axis, angle);

                angle = (float)Math.PI * 43 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return true;
            }
            else if (counter < 90)
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * (-32 + counter - 50) / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (130 - counter + 50) / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * 90 / 180;
                rot3 = Rotate(NullQ, axis, angle);

                angle = (float)Math.PI * 43 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return true;
            }
            else {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * 8 / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * 90 / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * 90 / 180;
                rot3 = Rotate(NullQ, axis, angle);

                angle = (float)Math.PI * 43 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return false;
            }
            



            
        }


        //EX3: this function will calculate the rotations necessary to move the arm of the robot until its end effector collides with the target (called Stud_target)
        //it will return true until it has reached its destination. The main project is set up in such a way that when the function returns false, the object will be droped and fall following gravity.
        //the only difference wtih exercise 2 is that rot3 has a swing and a twist, where the swing will apply to joint3 and the twist to joint4

        public bool PickStudAnimVertical(out MyQuat rot0, out MyQuat rot1, out MyQuat rot2, out MyQuat rot3)
        {
            float angle;
            MyVec axis;
            slowCounter++;
            if (slowCounter > 2)
            {
                slowCounter = 0;
                counter++;
            }
            if (counter < 20)
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * (-12 - counter) / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (110 + counter) / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (90 - counter) / 180;
                rot3 = Rotate(NullQ, axis, angle);

                angle = (float)Math.PI * 73 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return true;
            }
            else if (counter < 50)
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * (-32) / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (130) / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (70) / 180;
                rot3 = Rotate(NullQ, axis, angle);

                angle = (float)Math.PI * (93 - counter) / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return true;
            }
            else if (counter < 70)
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * (-32 + counter - 50) / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (130 - counter + 50) / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (70 + counter - 50) / 180;
                rot3 = Rotate(NullQ, axis, angle);

                angle = (float)Math.PI * 43 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return true;
            }
            else if (counter < 90)
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * (-32 + counter - 50) / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * (130 - counter + 50) / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * 90 / 180;
                rot3 = Rotate(NullQ, axis, angle);


                angle = (float)Math.PI * 43 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);


                return true;
            }
            else if (counter <170)
            {

                //here i am supposed to twist the rot3
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * 8 / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * 90 / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * 90 / 180;
                rot3 = Rotate(NullQ, axis, angle);


                angle = (float)Math.PI * (counter-80) / 180;
                axis.x = 0;
                axis.y = 0;
                axis.z = 1;
                rot3 = Rotate(rot3, axis, angle);


                angle = (float)Math.PI * 43 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return true;
            }
            else
            {
                axis.x = 1;
                axis.y = 0;
                axis.z = 0;
                angle = (float)Math.PI * 8 / 180;
                rot1 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * 90 / 180;
                rot2 = Rotate(NullQ, axis, angle);
                angle = (float)Math.PI * 90 / 180;
                rot3 = Rotate(NullQ, axis, angle);


                angle = (float)Math.PI * 90 / 180;
                axis.x = 0;
                axis.y = 0;
                axis.z = 1;
                rot3 = Rotate(rot3, axis, angle);


                angle = (float)Math.PI * 43 / 180;
                axis.x = 0;
                axis.y = 1;
                axis.z = 0;
                //todo: change this, use the function Rotate declared below
                rot0 = Rotate(NullQ, axis, angle);
                rot1 = Rotate(rot1, axis, angle);
                rot2 = Rotate(rot2, axis, angle);
                rot3 = Rotate(rot3, axis, angle);
                return false;
            }





        }


        public static MyQuat GetSwing(MyQuat rot3)
        {
            //todo: change the return value for exercise 3
            return rot3;

        }


        public static MyQuat GetTwist(MyQuat rot3)
        {
            //todo: change the return value for exercise 3
            return rot3;

        }




        #endregion


        #region private and internal methods

        internal int TimeSinceMidnight { get { return (DateTime.Now.Hour * 3600000) + (DateTime.Now.Minute * 60000) + (DateTime.Now.Second * 1000) + DateTime.Now.Millisecond; } }


        private static MyQuat NullQ
        {
            get
            {
                MyQuat a;
                a.w = 1;
                a.x = 0;
                a.y = 0;
                a.z = 0;

                return a;

            }
        }

        internal MyQuat Multiply(MyQuat q1, MyQuat q2) {
            MyQuat q3;
            q3.w = (q1.w * q2.w) - (q1.x * q2.x) - (q1.y * q2.y) - (q1.z * q2.z);
            q3.x = (q1.w * q2.x) + (q1.x * q2.w) - (q1.y * q2.z) + (q1.z * q2.y);
            q3.y = (q1.w * q2.y) + (q1.x * q2.z) + (q1.y * q2.w) - (q1.z * q2.x);
            q3.z = (q1.w * q2.z) - (q1.x * q2.y) + (q1.y * q2.x) + (q1.z * q2.w);

            //todo: change this so it returns a multiplication:
            return q3;

        }

        internal MyQuat Rotate(MyQuat currentRotation, MyVec axis, float angle)
        {
            MyQuat multiplier;
            float factor = (float) Math.Sin(angle / 2);
            multiplier.x = axis.x * factor;
            multiplier.y = axis.y * factor;
            multiplier.z = axis.z * factor;
            multiplier.w = (float)Math.Cos(angle / 2);
            //todo: change this so it takes currentRotation, and calculate a new quaternion rotated by an angle "angle" radians along the normalized axis "axis"
            MyQuat result = Multiply(currentRotation, multiplier);
            return result;

        }




        //todo: add here all the functions needed

        #endregion






    }
}
