using System;

namespace Server.Items
{
    public class YellowPaste : Item
    {
        [Constructable]
        public YellowPaste()
            : base(19672)
        {
			Stackable = true;
			Name = "Yellow Paste";
			Hue = 53;
        }

        public YellowPaste(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}