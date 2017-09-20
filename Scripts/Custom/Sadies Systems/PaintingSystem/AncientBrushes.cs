using System;
using Server.Engines.Craft;

namespace Server.Items
{
    public class AncientBrushes : BaseTool
    {
        [Constructable]
        public AncientBrushes()
            : base(4033)
        {
            this.Weight = 2.0;
			this.Hue = 2968;
			this.Name = "Ancient Brushes";
        }

        [Constructable]
        public AncientBrushes(int uses)
            : base(uses, 100)
        {
            this.Weight = 2.0;
        }

        public AncientBrushes(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefCooking.CraftSystem;
            }
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