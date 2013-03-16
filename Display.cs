using System;

namespace GSMClasses
{
    public class Display
    {
        private int _size;
        private int _numOfColors;

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public int NumOfColors
        {
            get { return _numOfColors; }
            set { _numOfColors = value; }
        }

        public Display(int size = 0, int numOfColors = 0)
        {
            this._size = size;
            this._numOfColors = numOfColors;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Size, this.NumOfColors);
        }
    }
}
