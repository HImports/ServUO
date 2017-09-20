using System;

namespace Server.Items
{
    public class MediumVioletPaint : Item
    {
        [Constructable]
        public MediumVioletPaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Medium Violet Paint";
			Hue = 23;
        }

        public MediumVioletPaint(Serial serial)
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