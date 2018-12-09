namespace Lab_4
{
    public class Beak
    {
        private BeakStatus _beakStatus;

        public Beak()
        {
            _beakStatus = BeakStatus.CLOSED;
        }

        public BeakStatus BeakStatus
        {
            get { return _beakStatus; }
            set { _beakStatus = value; }
        }
    }
}