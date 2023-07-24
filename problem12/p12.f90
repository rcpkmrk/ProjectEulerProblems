        integer number,i,k,j
        number = 0
        i = 1
        do while (i .gt. 0)
             number = number + i
             i = i + 1
             k = 0
             do j=1,number
                  if(mod(number,j)==0) then
                       k = k + 1
                       if(k .gt. 500) then
                            print*,number
                            read*,t
                       endif
                  endif
             enddo
        enddo
        stop
        end
