using System;

namespace Server.Items
{
    public class BlackPaint : Item
    {
        [Constructable]
        public BlackPaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Black Paint";
			Hue = 1;
        }

        public BlackPaint(Serial serial)
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