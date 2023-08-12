﻿using System.Text;
using Google.ProtocolBuffers;

namespace MHServerEmu.GameServer.Entities.Archives
{
    public class Condition
    {
        public ulong PrototypeId { get; set; }
        public uint Value { get; set; }

        public Condition(CodedInputStream stream)
        {
            PrototypeId = stream.ReadRawVarint64();
            Value = stream.ReadRawVarint32();
        }

        public Condition(ulong prototypeId, uint value)
        {
            PrototypeId = prototypeId;
            Value = value;
        }

        public byte[] Encode()
        {
            using (MemoryStream memoryStream = new())
            {
                CodedOutputStream stream = CodedOutputStream.CreateInstance(memoryStream);

                stream.WriteRawVarint64(PrototypeId);
                stream.WriteRawVarint64(Value);

                stream.Flush();
                return memoryStream.ToArray();
            }
        }

        public override string ToString()
        {
            using (MemoryStream memoryStream = new())
            using (StreamWriter streamWriter = new(memoryStream))
            {
                streamWriter.WriteLine($"PrototypeId: 0x{PrototypeId.ToString("X")}");
                streamWriter.WriteLine($"Value: 0x{Value.ToString("X")}");

                streamWriter.Flush();
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
    }
}
