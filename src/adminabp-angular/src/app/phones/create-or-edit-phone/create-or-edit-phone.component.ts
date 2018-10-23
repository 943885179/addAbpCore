import { PagedRequestDto } from '@shared/component-base/paged-listing-component-base';

import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdatePhoneNumberInput, PhoneNumberEditDto, PhoneNumberServiceProxy, PersonServiceProxy, PersonListDto } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-phone',
  templateUrl: './create-or-edit-phone.component.html',
  styleUrls: [
    'create-or-edit-phone.component.less'
  ],
})

export class CreateOrEditPhoneNumberComponent
  extends ModalComponentBase
  implements OnInit {
  /**
  * 编辑时DTO的id
  */
  id: any;
  type: string
  entity: PhoneNumberEditDto = new PhoneNumberEditDto();
  persons: PersonListDto[];
  /**
  * 初始化的构造函数
  */
  constructor(
    injector: Injector,
    private _phoneNumberService: PhoneNumberServiceProxy,
    private _personService: PersonServiceProxy
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this.init();
  }


  /**
  * 初始化方法
  */
  init(): void {
    this._phoneNumberService.getForEdit(this.id).subscribe(result => {
      this.entity = result.phoneNumber;
      this.type = result.phoneNumber.type.toString();
    });
    this._personService.getPersonListAsync().subscribe(result => {
      this.persons = result;
    });
  }

  /**
  * 保存方法,提交form表单
  */
  submitForm(): void {
    const input = new CreateOrUpdatePhoneNumberInput();
    this.entity.type = parseInt(this.type);//好像直接使用有点问题，只能做个中转或者直接修改Model
    this.entity.creationTime = null;//abp自动设置了时间
    this.entity.person = null;//不需要的值清空掉
    input.phoneNumber = this.entity;

    this.saving = true;

    this._phoneNumberService.createOrUpdate(input)
      .finally(() => (this.saving = false))
      .subscribe(() => {
        this.notify.success(this.l('SavedSuccessfully'));
        this.success(true);
      });
  }

  // =====End===
}
