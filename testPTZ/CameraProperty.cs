using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video.DirectShow;
using System.Threading.Tasks;

namespace testPTZ
{
    class CameraProperty
    {
        public CameraProperty(VideoCaptureDevice camera, CameraControlProperty prop)
        {
            theDevice = camera;
            camProp = prop;
            int defval, steps, cur;
            bool fail = false;
            try
            {
                fail = !theDevice.GetCameraPropertyRange(prop, out minLimit, out maxLimit, out steps, out defval, out camFlags);
                theDevice.GetCameraProperty(camProp, out cur, out camFlags);
            }
            catch (Exception e)
            {
                controllable = false;
            }
            if (fail)
                controllable = false;
        }

        private CameraControlProperty camProp;
        private VideoCaptureDevice theDevice;
        private int minLimit;
        private int maxLimit;
        private int numSteps = 10;
        private CameraControlFlags camFlags;
        private bool controllable = true;

        public int lowerLimit
        {
            get
            {
                return minLimit;
            }
        }

        public int upperLimit
        {
            get
            {
                return maxLimit;
            }
        }

        public int steps
        {
            get
            {
                return numSteps;
            }
            set
            {
                if(value > 1)
                    numSteps = value;
            }
        }

        public bool enabled
        {
            get { return controllable; }
        }

        public bool increase()
        {
            int deltaP = (maxLimit - minLimit) / numSteps;
            return move(deltaP);
        }

        public bool decrease()
        {
            int deltaP = -1 * (maxLimit - minLimit) / numSteps;
            return move(deltaP);
        }

        private bool move(int howMuch)
        {
            int curP;
            theDevice.GetCameraProperty(camProp, out curP, out camFlags);
            curP += howMuch;
            bool retVal = theDevice.SetCameraProperty(camProp, curP, camFlags);
            return retVal;
        }

    }
}
