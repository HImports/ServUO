using System;

namespace Server.Items
{
    public class RedPaste : Item
    {
        [Constructable]
        public RedPaste()
            : base(19672)
        {
			Stackable = true;
			Name = "Red Paste";
			Hue = 33;
        }

        public RedPaste(Serial serial)
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