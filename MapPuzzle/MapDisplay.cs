using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPuzzle
{
   class MapDisplay
   {
      Pen m_sGridPen;
      Pen m_sEndLocationPen;
      Font m_sMoveBonusFont;
      Brush m_sFontBrush;
      public MapDisplay()
      {
         m_sGridPen = new Pen(Color.Green);
         m_sMoveBonusFont = new Font("Courier New", 12);
         m_sFontBrush = new SolidBrush(Color.Blue);
         m_sEndLocationPen = new Pen(Color.Gold);
      }

      public void DrawGrid(Graphics sGraphics, int lSize)
      {
         for (int i=0; i<Map.Map_Size; i++)
         {
            for (int j=0; j<Map.Map_Size; j++)
            {
               sGraphics.DrawRectangle(m_sGridPen, i * lSize, j * lSize, lSize, lSize);
            }
         }
      }

      public void DrawBonuses(Graphics sGraphics, int lSize, Map sMap)
      {
         for (int i=0; i<Map.Map_Size; i++)
         {
            for (int j=0; j<Map.Map_Size; j++)
            {
               int lTileMoveBonus = sMap.GetTileMovementBonus(i, j);
               if (lTileMoveBonus != 0)
               {
                  sGraphics.DrawString(lTileMoveBonus.ToString(), m_sMoveBonusFont, m_sFontBrush, i * lSize, j * lSize);
               }
            }
         }
      }

      public void DrawEndLocation(Graphics sGraphics, int lSize, Map sMap)
      {
         for (int i = 0; i < Map.Map_Size; i++)
         {
            for (int j = 0; j < Map.Map_Size; j++)
            {
               if (sMap.IsTileEndTile(i, j) == true)
               {
                  sGraphics.DrawEllipse(m_sEndLocationPen, i * lSize, j * lSize, lSize, lSize);
               }
            }
         }
      }
   }
}
