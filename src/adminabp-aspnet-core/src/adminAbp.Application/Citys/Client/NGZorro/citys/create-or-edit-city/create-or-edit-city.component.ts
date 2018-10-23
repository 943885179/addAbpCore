
import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdateCityInput,CityEditDto, CityServiceProxy } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-city',
  templateUrl: './create-or-edit-city.component.html',
  styleUrls:[
	'create-or-edit-city.component.less'
  ],
})

export class CreateOrEditCityComponent
  extends ModalComponentBase
    implements OnInit {
    /**
    * 编辑时DTO的id
    */
    id: any ;

	  entity: CityEditDto=new CityEditDto();

    /**
    * 初始化的构造函数
    */
    constructor(
		injector: Injector,
		private _cityService: CityServiceProxy
	) {
		super(injector);
    }

    ngOnInit() :void{
		this.init();
    }


    /**
    * 初始化方法
    */
    init(): void {
		this._cityService.getForEdit(this.id).subscribe(result => {
			this.entity = result.city;
		});
    }

    /**
    * 保存方法,提交form表单
    */
    submitForm(): void {
		const input = new CreateOrUpdateCityInput();
		input.city = this.entity;

		this.saving = true;

		this._cityService.createOrUpdate(input)
		.finally(() => (this.saving = false))
		.subscribe(() => {
			this.notify.success(this.l('SavedSuccessfully'));
			this.success(true);
		});
    }

    // =====End===
}
