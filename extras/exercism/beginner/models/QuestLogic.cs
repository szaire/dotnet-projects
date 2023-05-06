using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beginner.models
{
    public class QuestLogic
    {
        public bool CanFastAttack(bool isAwake)
        {
            if (!isAwake)
            {
                return true;
            }
            return false;
        }

        public bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (!knightIsAwake && !archerIsAwake && prisonerIsAwake)            
            {
                return true;
            }
            return false;
        }

        public bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (!archerIsAwake && prisonerIsAwake)            
            {
                return true;
            }
            return false;
        }

        public bool CanFreePrisioner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool dogPresent)
        {
            if (!knightIsAwake && !archerIsAwake && prisonerIsAwake && dogPresent)
            {
                return true;
            }
            return false;
        }
    }
}