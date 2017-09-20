using System;

namespace Server.Items
{
    public class BluePaste : Item
    {
        [Constructable]
        public BluePaste()
            : base(19672)
        {
			Stackable = true;
			Name = "Blue Paste";
			Hue = 4;
        }

        public BluePaste(Serial serial)
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