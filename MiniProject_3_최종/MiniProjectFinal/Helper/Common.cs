using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectFinal.Helper
{
    // static(정적)으로 만드는 공통 연결 문자열
    public class Common
    {
        public static readonly string ConnString = "Data Source=localhost;" +
                                          "Initial Catalog=Login;" +
                                          "Persist Security Info=True;" +
                                          "User ID=sa;Encrypt=False;" +
                                          "Password=mssql_p@ss";

        public static string LoginId { get; set; }

        #region MD5 해시 알고리즘 암호화
        // FrmLogin, FrmLoginUser 공통된 부분 
        public static string GetMd5Hash(MD5 md5hash, string input)
        {
            // 입력문자열을 byte배열로 변환한 뒤 MD5 해시 처리
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("X2")); // 16진수 문자로 각 글자를 전부 변환
            }
            return builder.ToString();

            // => 앞서 만든 GetMd5Hash 대신 Helper.Common.GetMd5Hash으로 대체 
        }
        #endregion
    }
}
