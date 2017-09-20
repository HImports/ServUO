using System;

namespace Server.Items
{
    public class PumpkinOrangePaint : Item
    {
        [Constructable]
        public PumpkinOrangePaint()
            : base(19674)
        {
			Stackable = true;
			Name = "Pumpkin Orange Paint";
			Hue = 143;
        }

        public PumpkinOrangePaint(Serial serial)
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