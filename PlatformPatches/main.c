#include <dlfcn.h>

typedef int (*mono_main_type) (int argc, char* argv[]);

int
main (int argc, char* argv[])
{
  // work around Android's linker which does not support LD_LIBRARY_PATH...
  void* libmono = dlopen ("/data/data/com.koushikdutta.mono/libmono.so", RTLD_NOW);
  void* mono_main_ptr = dlsym (libmono, "mono_main");
  mono_main_type mono_main = (mono_main_type)mono_main_ptr;
  return mono_main (argc, argv);
}