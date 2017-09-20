using System;

namespace Server.Items
{
    public class TealPaint : Item
    {
        [Constructable]
        public TealPaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Teal Paint";
			Hue = 583;
        }

        public TealPaint(Serial serial)
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