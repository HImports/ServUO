using System;

namespace Server.Items
{
    public class BloodOrangePaint : Item
    {
        [Constructable]
        public BloodOrangePaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Blood Orange Paint";
			Hue = 40;
        }

        public BloodOrangePaint(Serial serial)
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