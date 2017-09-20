using System;

namespace Server.Items
{
    public class PurplePaint : Item
    {
        [Constructable]
        public PurplePaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Purple Paint";
			Hue = 113;
        }

        public PurplePaint(Serial serial)
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