﻿using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PhoneNumberTypeService : IPhoneNumberTypeService
    {
        private readonly IPhoneNumberTypeRepository _phoneNumberTypeRepository;
        public PhoneNumberTypeService(IPhoneNumberTypeRepository phoneNumberTypeRepository)
        {
            _phoneNumberTypeRepository = phoneNumberTypeRepository;

        }

        public async Task<List<PhoneNumberType>> FindAllAsync() => (await _phoneNumberTypeRepository.FindAllAsync()).ToList();
    }
}
