namespace Common.Model
{
    public class Bss
    {
        private bool _myBssInstaled;
        private bool _connectionEnabled;
        private int _mbDownloaded;
        private int _mbUploaded;
        private int _mbSoft;
        private bool _connected;
        private bool _uploaded;
        private bool _downloaded;
        private int _deletedMb;

        public Bss()
        {
            _myBssInstaled = false;
            _connectionEnabled = false;
            _mbUploaded = 0;
            _mbDownloaded = 0;
            _mbSoft = 0;
            _connected = false;
            _downloaded = false;
            _uploaded = false;
            _deletedMb = 0;
        }

        public int DeletedMb
        {
            get => _deletedMb;
            set => _deletedMb = value;
        }

        public bool Uploaded
        {
            get => _uploaded;
            set => _uploaded = value;
        }

        public bool Downloaded
        {
            get => _downloaded;
            set => _downloaded = value;
        }

        public bool Connected
        {
            get => _connected;
            set => _connected = value;
        }

        public int MbSoft
        {
            get => _mbSoft;
            set => _mbSoft = value;
        }

        public bool MyBssInstaled
        {
            get => _myBssInstaled;
            set => _myBssInstaled = value;
        }

        public int MbDownloaded
        {
            get => _mbDownloaded;
            set => _mbDownloaded = value;
        }

        public int MbUploaded
        {
            get => _mbUploaded;
            set => _mbUploaded = value;
        }

        public bool ConnectionEnabled
        {
            get => _connectionEnabled;
            set => _connectionEnabled = value;
        }
    }
}
