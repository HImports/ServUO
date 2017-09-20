using System;

namespace Server.Items
{
    public class WhitePaint : Item
    {
        [Constructable]
        public WhitePaint()
            : base(19674)
        {
			Stackable = true;
			Name = "White Paint";
			Hue = 1150;
        }

        public WhitePaint(Serial serial)
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