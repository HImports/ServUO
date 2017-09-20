using System;

namespace Server.Items
{
    public class GreyPaint : Item
    {
        [Constructable]
        public GreyPaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Grey Paint";
			Hue = 914;
        }

        public GreyPaint(Serial serial)
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