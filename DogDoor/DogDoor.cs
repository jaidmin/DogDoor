using System.Security.Cryptography.X509Certificates;

namespace DogDoor
{
    public class DogDoor
    {
        public bool Open { get; set; }

        public DogDoor()
        {
            Open = false;
        }

        public void OpenDoor()
        {
            Open = true;
        }

        public void CloseDoor()
        {
            Open = false;
        }

        public bool IsOpen()
        {
            return Open;
        }
    }
}