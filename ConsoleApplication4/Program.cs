using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication4
{
    public class Extension
    {
        public string Ext;
        public string Description;
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://www.fileinfo.com/extension/{0}";

            var exts = new Dictionary<int, Extension>
                       {
                           {1, new Extension() {Ext = "doc", Description = ""}},
                           {2, new Extension() {Ext = "docx", Description = ""}},
                           {3, new Extension() {Ext = "dot", Description = ""}},
                           {4, new Extension() {Ext = "dotx", Description = ""}},
                           {5, new Extension() {Ext = "ppt", Description = ""}},
                           {6, new Extension() {Ext = "pptx", Description = ""}},
                           {7, new Extension() {Ext = "pps", Description = ""}},
                           {8, new Extension() {Ext = "ppsx", Description = ""}},
                           {9, new Extension() {Ext = "xls", Description = ""}},
                           {10, new Extension() {Ext = "xlsx", Description = ""}},
                           {11, new Extension() {Ext = "xml", Description = ""}},
                           {12, new Extension() {Ext = "mdb", Description = ""}},
                           {13, new Extension() {Ext = "one", Description = ""}},
                           {14, new Extension() {Ext = "mpp", Description = ""}},
                           {15, new Extension() {Ext = "pub", Description = ""}},
                           {16, new Extension() {Ext = "vsd", Description = ""}},
                           {17, new Extension() {Ext = "msg", Description = ""}},
                           {18, new Extension() {Ext = "txt", Description = ""}},
                           {19, new Extension() {Ext = "rtf", Description = ""}},
                           {20, new Extension() {Ext = "wks", Description = ""}},
                           {21, new Extension() {Ext = "wdb", Description = ""}},
                           {22, new Extension() {Ext = "wps", Description = ""}},
                           {23, new Extension() {Ext = "htm", Description = ""}},
                           {24, new Extension() {Ext = "html", Description = ""}},
                           {25, new Extension() {Ext = "css", Description = ""}},
                           {26, new Extension() {Ext = "sxw", Description = ""}},
                           {27, new Extension() {Ext = "odt", Description = ""}},
                           {28, new Extension() {Ext = "ods", Description = ""}},
                           {29, new Extension() {Ext = "odp", Description = ""}},
                           {30, new Extension() {Ext = "odf", Description = ""}},
                           {31, new Extension() {Ext = "pdf", Description = ""}},
                           {32, new Extension() {Ext = "tax", Description = ""}},
                           {33, new Extension() {Ext = "t05", Description = ""}},
                           {34, new Extension() {Ext = "t06", Description = ""}},
                           {35, new Extension() {Ext = "t07", Description = ""}},
                           {36, new Extension() {Ext = "t08", Description = ""}},
                           {37, new Extension() {Ext = "t09", Description = ""}},
                           {38, new Extension() {Ext = "t10", Description = ""}},
                           {39, new Extension() {Ext = "qbb", Description = ""}},
                           {40, new Extension() {Ext = "mny", Description = ""}},
                           {41, new Extension() {Ext = "h", Description = ""}},
                           {42, new Extension() {Ext = "c", Description = ""}},
                           {43, new Extension() {Ext = "as", Description = ""}},
                           {44, new Extension() {Ext = "cpp", Description = ""}},
                           {45, new Extension() {Ext = "cs", Description = ""}},
                           {46, new Extension() {Ext = "vb", Description = ""}},
                           {47, new Extension() {Ext = "vbs", Description = ""}},
                           {48, new Extension() {Ext = "cmd", Description = ""}},
                           {49, new Extension() {Ext = "bat", Description = ""}},
                           {50, new Extension() {Ext = "ps1", Description = ""}},
                           {51, new Extension() {Ext = "java", Description = ""}},
                           {52, new Extension() {Ext = "js", Description = ""}},
                           {53, new Extension() {Ext = "pl", Description = ""}},
                           {54, new Extension() {Ext = "mmap", Description = ""}},
                           {55, new Extension() {Ext = "rb", Description = ""}},
                           {56, new Extension() {Ext = "py", Description = ""}},
                           {57, new Extension() {Ext = "php", Description = ""}},
                           {58, new Extension() {Ext = "aif", Description = ""}},
                           {59, new Extension() {Ext = "au", Description = ""}},
                           {60, new Extension() {Ext = "cda", Description = ""}},
                           {61, new Extension() {Ext = "med", Description = ""}},
                           {62, new Extension() {Ext = "mid", Description = ""}},
                           {63, new Extension() {Ext = "midi", Description = ""}},
                           {64, new Extension() {Ext = "mod", Description = ""}},
                           {65, new Extension() {Ext = "mpa", Description = ""}},
                           {66, new Extension() {Ext = "mp3", Description = ""}},
                           {67, new Extension() {Ext = "ogg", Description = ""}},
                           {68, new Extension() {Ext = "ra", Description = ""}},
                           {69, new Extension() {Ext = "rmi", Description = ""}},
                           {70, new Extension() {Ext = "rmx", Description = ""}},
                           {71, new Extension() {Ext = "rv", Description = ""}},
                           {72, new Extension() {Ext = "s3m", Description = ""}},
                           {73, new Extension() {Ext = "sfx", Description = ""}},
                           {74, new Extension() {Ext = "sid", Description = ""}},
                           {75, new Extension() {Ext = "snd", Description = ""}},
                           {76, new Extension() {Ext = "spc", Description = ""}},
                           {77, new Extension() {Ext = "voc", Description = ""}},
                           {78, new Extension() {Ext = "vvs", Description = ""}},
                           {79, new Extension() {Ext = "wav", Description = ""}},
                           {80, new Extension() {Ext = "wma", Description = ""}},
                           {81, new Extension() {Ext = "xm", Description = ""}},
                           {82, new Extension() {Ext = "asf", Description = ""}},
                           {83, new Extension() {Ext = "avi", Description = ""}},
                           {84, new Extension() {Ext = "divx", Description = ""}},
                           {85, new Extension() {Ext = "mpg", Description = ""}},
                           {86, new Extension() {Ext = "mpg4", Description = ""}},
                           {87, new Extension() {Ext = "mov", Description = ""}},
                           {88, new Extension() {Ext = "rm", Description = ""}},
                           {89, new Extension() {Ext = "vob", Description = ""}},
                           {90, new Extension() {Ext = "wmv", Description = ""}},
                           {91, new Extension() {Ext = "xvid", Description = ""}},
                           {94, new Extension() {Ext = "docm", Description = ""}},
                           {97, new Extension() {Ext = "ost", Description = ""}},
                           {100, new Extension() {Ext = "pot", Description = ""}},
                           {101, new Extension() {Ext = "potx", Description = ""}},
                           {104, new Extension() {Ext = "pptm", Description = ""}},
                           {106, new Extension() {Ext = "pst", Description = ""}},
                           {108, new Extension() {Ext = "xlt", Description = ""}},
                           {110, new Extension() {Ext = "xlsm", Description = ""}},
                           {111, new Extension() {Ext = "xltx", Description = ""}},
                           {112, new Extension() {Ext = "aa", Description = ""}},
                           {113, new Extension() {Ext = "aac", Description = ""}},
                           {115, new Extension() {Ext = "aiff", Description = ""}},
                           {134, new Extension() {Ext = "swa", Description = ""}},
                           {143, new Extension() {Ext = "mpeg", Description = ""}},
                           {144, new Extension() {Ext = "mpe", Description = ""}},
                           {152, new Extension() {Ext = "bmp", Description = ""}},
                           {153, new Extension() {Ext = "gif", Description = ""}},
                           {154, new Extension() {Ext = "jpg", Description = ""}},
                           {155, new Extension() {Ext = "jpeg", Description = ""}},
                           {156, new Extension() {Ext = "pct", Description = ""}},
                           {157, new Extension() {Ext = "pict", Description = ""}},
                           {158, new Extension() {Ext = "png", Description = ""}},
                           {159, new Extension() {Ext = "psb", Description = ""}},
                           {160, new Extension() {Ext = "raw", Description = ""}},
                           {161, new Extension() {Ext = "tif", Description = ""}},
                           {162, new Extension() {Ext = "tiff", Description = ""}},
                           {163, new Extension() {Ext = "app", Description = ""}},
                           {164, new Extension() {Ext = "com", Description = ""}},
                           {165, new Extension() {Ext = "dll", Description = ""}},
                           {166, new Extension() {Ext = "exe", Description = ""}},
                           {167, new Extension() {Ext = "gadget", Description = ""}},
                           {168, new Extension() {Ext = "bin", Description = ""}},
                           {169, new Extension() {Ext = "deb", Description = ""}},
                           {170, new Extension() {Ext = "dmg", Description = ""}},
                           {171, new Extension() {Ext = "gz", Description = ""}},
                           {172, new Extension() {Ext = "img", Description = ""}},
                           {173, new Extension() {Ext = "iso", Description = ""}},
                           {174, new Extension() {Ext = "jar", Description = ""}},
                           {175, new Extension() {Ext = "pkg", Description = ""}},
                           {176, new Extension() {Ext = "rar", Description = ""}},
                           {177, new Extension() {Ext = "rpm", Description = ""}},
                           {179, new Extension() {Ext = "sitx", Description = ""}},
                           {180, new Extension() {Ext = "tar", Description = ""}},
                           {181, new Extension() {Ext = "tgz", Description = ""}},
                           {182, new Extension() {Ext = "war", Description = ""}},
                           {183, new Extension() {Ext = "zip", Description = ""}},
                           {184, new Extension() {Ext = "zipx", Description = ""}},
                           {185, new Extension() {Ext = "7z", Description = ""}},
                           {186, new Extension() {Ext = "dsk", Description = ""}},
                           {187, new Extension() {Ext = "ova", Description = ""}},
                           {188, new Extension() {Ext = "ovf", Description = ""}},
                           {189, new Extension() {Ext = "std", Description = ""}},
                           {190, new Extension() {Ext = "vdi", Description = ""}},
                           {191, new Extension() {Ext = "vhd", Description = ""}},
                           {192, new Extension() {Ext = "vmdk", Description = ""}},
                           {193, new Extension() {Ext = "vmem", Description = ""}},
                           {194, new Extension() {Ext = "vmsn", Description = ""}},
                           {195, new Extension() {Ext = "vmss", Description = ""}}
                       };

            WebClient webClient = new WebClient();

            foreach (var ext in exts)
            {
                var pageText = webClient.DownloadString(string.Format(url, ext.Value.Ext));

                //<meta name="keywords" content=".*?, (.*?),
                var regex = new Regex("<meta name=\"keywords\" content=\".*?, (?<description>.*?),");
                var matches = regex.Matches(pageText);

                foreach (Match m in matches)
                {
                    var d = m.Groups["description"];
                    ext.Value.Description = d.Value;
                }

                Console.WriteLine("INSERT INTO [dbo].[FileExtension] ([ExtensionId], [Extension], [Description]) VALUES ({0}, N'{1}', N'{2}')",
                    ext.Key, ext.Value.Ext, ext.Value.Description);
            }

            Console.ReadKey();
        }
    }
}
