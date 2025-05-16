import { AbstractControl, ValidationErrors } from '@angular/forms';

export class ValidatorCnpj {
  static validate(control: AbstractControl): ValidationErrors | null {
    const cnpj = control.value;
    if (!cnpj) return null; // Ignorar caso esteja vazio

    const cleanedCnpj = cnpj.replace(/\D/g, '');
    if (cleanedCnpj.length !== 14 || !ValidatorCnpj.isValidCNPJ(cleanedCnpj)) {
      return { invalidCnpj: true };
    }

    return null; // CNPJ válido
  }

  private static isValidCNPJ(cnpj: string): boolean {
    const validateDigits = (cnpj: string, length: number) => {
      let sum = 0;
      let pos = length - 7;
      for (let i = 0; i < length; i++) {
        sum += Number(cnpj[i]) * pos--;
        if (pos < 2) pos = 9;
      }
      const digit = sum % 11 < 2 ? 0 : 11 - (sum % 11);
      return digit === Number(cnpj[length]);
    };

    return validateDigits(cnpj, 12) && validateDigits(cnpj, 13);
  }
}