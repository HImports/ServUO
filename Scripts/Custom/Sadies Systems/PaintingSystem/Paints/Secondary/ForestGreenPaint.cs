using System;

namespace Server.Items
{
    public class ForestGreenPaint : Item
    {
        [Constructable]
        public ForestGreenPaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Forest Green Paint";
			Hue = 72;
        }

        public ForestGreenPaint(Serial serial)
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