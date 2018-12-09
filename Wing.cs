namespace Lab_4
{
    public class Wing
    {
        private WingStatus _wingStatus;

        public Wing()
        {
            _wingStatus = WingStatus.CLOSED;
        }

        public WingStatus WingStatus
        {
            get { return _wingStatus; }
            set { _wingStatus = value; }
        }
    }
}