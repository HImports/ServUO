using System;

namespace Server.Items
{
    public class YellowPaint : Item
    {
        [Constructable]
        public YellowPaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Yellow Paint";
			Hue = 53;
        }

        public YellowPaint(Serial serial)
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