namespace RedactedFastFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binary = new BinaryReader(new MemoryStream(File.ReadAllBytes(
                @"D:\SteamLibrary\steamapps\common\Call of Duty HQ\cod23\ww_code_post_gfx.ff")));
        }
    }
}
