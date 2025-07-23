.code

_DllMainCRTStartup proc parameter1:DWORD, parameter2:DWORD, parameter3:DWORD  ;entry point
    mov eax, 1
    ret
_DllMainCRTStartup endp


getnumber proc EXPORT
   rdrand rax
   mov rdx,7FFFFFFFFFFFFFFFh
   and rax,rdx  ;or m64
   ret
getnumber endp


END


