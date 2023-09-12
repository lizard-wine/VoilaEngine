using System;
using System.Collections.Generic;

namespace VoilaEngine{
    public class Vector2{
        
        public double x { get; set; }
        public double y { get; set; }

        public Vector2 normalized{get{

            double _x = x / Math.Sqrt(x * x + y * y);
            double _y = y / Math.Sqrt(x * x + y * y);

            return new Vector2(double.IsNaN(_x) ? 0 : _x, double.IsNaN(_y) ? 0 : _y);
        }}
        public double magnitude{
            get{
                return Math.Sqrt(x * x + y * y);
            }
        }
        public double sqrMagnitude{
            get{
                return x * x + y * y;
            }
        }

        public Vector2(double x, double y){
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator *(Vector2 self, int value){
            return new Vector2(self.x * value, self.y * value);
        }
        public static Vector2 operator *(Vector2 self, float value){
            return new Vector2(self.x * value, self.y * value);
        }
        public static Vector2 operator *(Vector2 self, double value){
            return new Vector2(self.x * value, self.y * value);
        }
        public static Vector2 operator *(Vector2 self, Vector2 value){
            return new Vector2(self.x * value.x, self.y * value.y);
        }

        public static Vector2 operator +(Vector2 self, int value){
            return new Vector2(self.x + value, self.y + value);
        }
        public static Vector2 operator +(Vector2 self, float value){
            return new Vector2(self.x + value, self.y + value);
        }
        public static Vector2 operator +(Vector2 self, double value){
            return new Vector2(self.x + value, self.y + value);
        }
        public static Vector2 operator +(Vector2 self, Vector2 value){
            return new Vector2(self.x + value.x, self.y + value.y);
        }

        public static Vector2 operator -(Vector2 self, int value){
            return new Vector2(self.x - value, self.y - value);
        }
        public static Vector2 operator -(Vector2 self, float value){
            return new Vector2(self.x - value, self.y - value);
        }
        public static Vector2 operator -(Vector2 self, double value){
            return new Vector2(self.x - value, self.y - value);
        }
        public static Vector2 operator -(Vector2 self, Vector2 value){
            return new Vector2(self.x - value.x, self.y - value.y);
        }

        public static Vector2 operator /(Vector2 self, int value){
            return new Vector2(self.x / value, self.y / value);
        }
        public static Vector2 operator /(Vector2 self, float value){
            return new Vector2(self.x / value, self.y / value);
        }
        public static Vector2 operator /(Vector2 self, double value){
            return new Vector2(self.x / value, self.y / value);
        }
        public static Vector2 operator /(Vector2 self, Vector2 value){
            return new Vector2(self.x / value.x, self.y / value.y);
        }


    }
    public class Vector3{
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Vector3(double x, double y, double z){
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3 normalized{get{
            double _x = x / Math.Sqrt(x * x + y * y + z * z);
            double _y = y / Math.Sqrt(x * x + y * y + z * z);
            double _z = z / Math.Sqrt(x * x + y * y + z * z);

            return new Vector3(double.IsNaN(_x) ? 0 : _x, double.IsNaN(_y) ? 0 : _y, double.IsNaN(_z) ? 0 : _z);
        }}
        public double magnitude{
            get{
                return Math.Sqrt(x * x + y * y + z * z);
            }
        }
        public double sqrMagnitude{
            get{
                return x * x + y * y + z * z;
            }
        }

        public static Vector3 operator *(Vector3 self, int value){
            return new Vector3(self.x * value, self.y * value, self.z * value);
        }
        public static Vector3 operator *(Vector3 self, float value){
            return new Vector3(self.x * value, self.y * value, self.z * value);
        }
        public static Vector3 operator *(Vector3 self, double value){
            return new Vector3(self.x * value, self.y * value, self.z * value);
        }
        public static Vector3 operator *(Vector3 self, Vector3 value){
            return new Vector3(self.x * value.x, self.y * value.y, self.z * value.z);
        }

        public static Vector3 operator +(Vector3 self, int value){
            return new Vector3(self.x + value, self.y + value, self.z + value);
        }
        public static Vector3 operator +(Vector3 self, float value){
            return new Vector3(self.x + value, self.y + value, self.z + value);
        }
        public static Vector3 operator +(Vector3 self, double value){
            return new Vector3(self.x + value, self.y + value, self.z + value);
        }
        public static Vector3 operator +(Vector3 self, Vector3 value){
            return new Vector3(self.x + value.x, self.y + value.y, self.z + value.z);
        }

        public static Vector3 operator -(Vector3 self, int value){
            return new Vector3(self.x - value, self.y - value, self.z - value);
        }
        public static Vector3 operator -(Vector3 self, float value){
            return new Vector3(self.x - value, self.y - value, self.z - value);
        }
        public static Vector3 operator -(Vector3 self, double value){
            return new Vector3(self.x - value, self.y - value, self.z - value);
        }
        public static Vector3 operator -(Vector3 self, Vector3 value){
            return new Vector3(self.x - value.x, self.y - value.y, self.z - value.z);
        }

        public static Vector3 operator /(Vector3 self, int value){
            return new Vector3(self.x / value, self.y / value, self.z / value);
        }
        public static Vector3 operator /(Vector3 self, float value){
            return new Vector3(self.x / value, self.y / value, self.z / value);
        }
        public static Vector3 operator /(Vector3 self, double value){
            return new Vector3(self.x / value, self.y / value, self.z / value);
        }
        public static Vector3 operator /(Vector3 self, Vector3 value){
            return new Vector3(self.x / value.x, self.y / value.y, self.z / value.z);
        }

}
}