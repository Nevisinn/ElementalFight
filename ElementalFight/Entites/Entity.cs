using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalFight.Entites
{
    public class Entity
    {
        public int posX;
        public int posY;



        public bool IsMoving;

        public int currentAnimation;
        public int currentFrame;
        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;

        public int size;

        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int runFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.spriteSheet = spriteSheet;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            size = 150;
            currentAnimation = 0;
            currentFrame = 0;
        }

        public void Move(int dirX,int dirY)
        {
            posX += dirX;
            posY += dirY;
        }

        public void PlayAnimation(Graphics g)
        {
            

            if (currentFrame < idleFrames - 1)
                currentFrame++;
            else currentFrame = 0;
          
        }
    }
}
