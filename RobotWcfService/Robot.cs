using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Robot : IRobot
    {
        private IList<IInversion> _inversions;

        //user-inversion Dictionary
        private IDictionary<Guid, IInversion> _userInversionLookup;

        public Robot()
        {
            _inversions = new List<IInversion>();
            _userInversionLookup = new Dictionary<Guid, IInversion>();
        }


        public Guid InitInversion(Guid ownerId, Settings settings)
        {
            var inversion = InversionFactory.CreateInversion( ownerId, settings);
            _inversions.Add(inversion);
            _userInversionLookup.Add(ownerId, inversion);
            
            return inversion.InversionId;

        }

        public bool StartInversion(Guid ownerId, Guid inversionId)
        {
            IInversion inversion = null;
            foreach (var inv in _inversions.Where(inv => inv.InversionId.Equals(inversionId)))
            {
                inversion = inv;
            }

            return inversion != null && inversion.Start();
        }

        public bool StopInversion(Guid ownerId, Guid inversionId)
        {
            IInversion inversion = null;
            foreach (var inv in _inversions)
            {
                if (inv.InversionId.Equals(inversionId))
                {
                    inversion = inv;
                }
            }

            return inversion != null && inversion.Stop();
        }


        public IList<IInversion> QueryInversion(Guid wellId)
        {
            var inversionQuery = from inversion in _inversions
                                 where inversion.WellId.Equals(wellId)
                                 select inversion;
            var inversionList = inversionQuery.ToList();

            return inversionList;
            
        }

        public IInversion RetrieveInversion(Guid userId, Guid inversionId, string accessCode)
        {
            IInversion inversion = null;
            var inversionQuery = from inv in _inversions
                                 where inv.InversionId.Equals(inversionId)
                                 select inv;
            foreach (var inv in inversionQuery)
            {
                inversion = inv;
            }

            if (inversion != null && !inversion.CheckAccessCode(accessCode))
            {
                return null;
            }

            // Add user who can access the inversion into user-inversion dictionary
            _userInversionLookup.Add(userId, inversion);

            return inversion;
        }

        /// <summary>
        /// Find users by inversionId based on the user-inversion Dictionary
        /// </summary>
        /// <param name="inversionId"></param>
        /// <returns></returns>
        public IList<Guid> GetUsersByInversionId(Guid inversionId )
        {
            var users = new List<Guid>();

            var usersQuery = from user in _userInversionLookup
                             where user.Value.InversionId.Equals(inversionId)
                             select user;

            foreach (var keyValuePair in usersQuery)
            {
                users.Add(keyValuePair.Key);
            }

            return users;
        }


    }

}
