using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JiraExtractor.Writers.CSV
{
    public interface ICsvLine
    {
        string GetLine();
    }
}
