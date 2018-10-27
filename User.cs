using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Notes
{
    class User
    {

        #region Const
        #endregion

        #region Fields
        private Guid _guid;
        private string _userName;
        private string _password;
        private List<Note> _notes;
        #endregion
        #region Properties 
        public Guid Guid
        {
            get
            {
                return _guid;
            }
            private set
            {
                _guid = value;
            }
        }
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }
        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }
        public List<Note> Notes
        {
            get { return _notes; }
            private set { _notes = value; }
        }
        #endregion
        #region Constructor

        public User(string userName, string password) : this()
        {
            _guid = Guid.NewGuid();
            _userName = UserName;

            SetPassword(password);
        }

        private User()
        {
            _notes = new List<Note>();
        }

        #endregion

        private void SetPassword(string password)
        {
            if (password == null) throw new ArgumentNullException("emptyPassword");

            //encrypt data
            var data = Encoding.Unicode.GetBytes(password);
            byte[] encrypted = ProtectedData.Protect(data, null, Scope);

            //return as base64 string
            _password = Convert.ToBase64String(encrypted);
        }
        public bool CheckPassword(string password)
        {
            if (password == null) throw new ArgumentNullException("cipher");

            //parse base64 string
            byte[] data = Convert.FromBase64String(_password);

            //decrypt data
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            string res = Encoding.Unicode.GetString(decrypted);

            data = Encoding.Unicode.GetBytes(password);
            Console.WriteLine($"2: {res}");
            return res == password;
        
            try
            {
                if (password == null) throw new ArgumentNullException("cipher");

                //parse base64 string
                byte[] data = Convert.FromBase64String(password);

                //decrypt data
                byte[] decrypted = ProtectedData.Unprotect(data, null, Scope);
                string res = Encoding.Unicode.GetString(decrypted);

                data = Convert.FromBase64String(_password);
                decrypted = ProtectedData.Unprotect(data, null, Scope);
                string res2 = Encoding.Unicode.GetString(decrypted);
                return res == res2;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public override string ToString()
        {
            return UserName;
        }
    }
}
