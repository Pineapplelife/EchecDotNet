using System.Text;

namespace Test {
    class Program {
        static void Main(string[] args) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++){
                sb.Append("abc");
            }
            string s = sb.ToString();

        }
    }
}
