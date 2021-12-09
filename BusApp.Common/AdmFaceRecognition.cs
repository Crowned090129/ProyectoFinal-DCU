using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace BusApp.Common
{
    public  class AdmFaceRecognition
    {
        FaceRec faceRecognition = new FaceRec();

        public void OpenCamera(PictureBox box1, PictureBox box2) 
        {
            faceRecognition.openCamera(box1, box2);
        }

        public void SaveImage(string name) 
        {
            faceRecognition.Save_IMAGE(name);
        }

        public void Recognition()
        {
            faceRecognition.isTrained = true;
        }
    }
}
