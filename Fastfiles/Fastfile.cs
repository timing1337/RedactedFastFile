using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RedactedFastFile.Fastfiles
{

    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public struct FastfileHeader
    {

    }
    public class Fastfile
    {
        public static unsafe void Read(string zone)
        {
            string fastFilePath = $@"D:\SteamLibrary\steamapps\common\Call of Duty HQ\cod23\{zone}.ff";
            string patchFilePath = $@"D:\SteamLibrary\steamapps\common\Call of Duty HQ\cod23\{zone}.fp";
            var fastFileReader = new BinaryReader(new MemoryStream(File.ReadAllBytes(fastFilePath)));
            var patchFileReader = new BinaryReader(new MemoryStream(File.ReadAllBytes(patchFilePath)));

            // Parse first header

            var headerSize = sizeof(FastfileHeader);

            var fastFileHeader = new BinaryReader(new MemoryStream(fastFileReader.ReadBytes(headerSize)));
            var patchFileHeader = new BinaryReader(new MemoryStream(patchFileReader.ReadBytes(56 + headerSize * 2)));

            // Parse diff headers
            // not sure what this contains lol
            patchFileHeader.ReadBytes(56);

            var patchFileHeader1 = new BinaryReader(new MemoryStream(patchFileHeader.ReadBytes(headerSize)));
            var patchFileHeader2 = new BinaryReader(new MemoryStream(patchFileHeader.ReadBytes(headerSize)));
        }
    }
}
