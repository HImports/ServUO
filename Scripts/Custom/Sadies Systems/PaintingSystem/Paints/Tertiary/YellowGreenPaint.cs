using System;

namespace Server.Items
{
    public class YellowGreenPaint : Item
    {
        [Constructable]
        public YellowGreenPaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Yellow Green Paint";
			Hue = 58;
        }

        public YellowGreenPaint(Serial serial)
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