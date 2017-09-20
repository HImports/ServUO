using System;

namespace Server.Items
{
    public class BluePaint : Item
    {
        [Constructable]
        public BluePaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Blue Paint";
			Hue = 4;
        }

        public BluePaint(Serial serial)
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